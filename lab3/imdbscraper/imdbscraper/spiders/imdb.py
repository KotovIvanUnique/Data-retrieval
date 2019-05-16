import scrapy
import re

class ImdbSpider(scrapy.Spider):
    name = 'imdbspider'
    
    def __init__(self, filename=None):
        if filename:
            with open(filename, 'r') as file:
                self.urls=file.read().split('\n')
        
    def parse(self, response):
        '''
        Название (text)
        Год (int)
        Дата премьеры (datetime)
        Список жанров (text[])
        Режиссёр (text)
        Звёзды фильма(первые 3 фамилии) (text[])
        Аннотация (Storyline) (text)
        Краткое содержание (Synopsis) (text)        
        '''
        yield {'id': re.findall('https://www.imdb.com/title/tt(\d{7})/', response.url)}
        
        for title in response.css('.title_wrapper>h1'):
            yield {'title': title.css('h1 ::text').get().replace(u'\xa0', u'')}
            yield {'year': title.css('a ::text').get()}
        
        for rd_page in response.css('a[href*="releaseinfo?ref_=tt_dt_dt"]'):
            yield response.follow(rd_page, self.parseReleaseDate)
                  
        #Пример xpath селекторов
        for rating in response.css('.ratingValue>strong>span'):
            yield {'rating': rating.css('span ::text').get()}
            yield {'ratingXPath': rating.xpath('string(.)').extract()}


        for storyline in response.css('#titleStoryLine > div:nth-child(3) > p > span'):
            yield {'storyline': storyline.xpath('text()').extract()}
        
        for plot_page in response.css('a[href*="/synopsis?ref_=tt_stry_pl"]'):
            yield response.follow(plot_page, self.parseSynopsis)
        
        genres=[]
        for genre in response.css('div.subtext>a[href*="genres"]'):
            genres.append(genre.xpath('text()').extract())
        yield {'genres': genres}
        
        directors=[]
        for director in response.css('a[href*="tt_ov_dr"]'):
            directors.append(director.xpath('text()').extract())
        yield {'directors': directors}
              
        top_3_cast=[]
        for cast in response.css('#titleCast>table').css('a[href*="name"][href*="/?ref_=tt_cl_t"]')[:3]:
            top_3_cast.append(cast.xpath('text()').extract())
        yield {'top_3_cast': top_3_cast}        
    
    def parseReleaseDate(self, response):
        rd=[]
        for tr in response.css('tr.ipl-zebra-list__item.release-date-item'):
            a=tr.css('a').xpath('text()').extract()
            tds=[td.xpath('text()').extract() for td in tr.css('td')]
            rd.append([a[0], ' '.join(itertools.chain.from_iterable(tds))])
        yield {'releasedates':rd}
        
    def parseSynopsis(self, response):
        for syno in response.css('#plot-synopsis-content>li'):
            yield {'synopsis': syno.xpath('text()').extract()}
            
   