import requests
from bs4 import BeautifulSoup

url1 = 'http://quotes.toscrape.com'
url = 'https://www.jeyamohan.in/130246/?fbclid=IwAR0NzjMq2LoUcm2Fv2ziKQSSgYfLboC8n_-IqfgylMh4Q1q1csHS9hozDv0#.XrBvlqhKhnK'
response = requests.get(url1)
soup = BeautifulSoup(response.text, 'lxml')
quotes = soup.find_all('span', class_='text')
authors = soup.find_all('small', class_='author')
tags = soup.find_all('div', class_='tags')

for i in range(0, len(quotes)):
    print( quotes[i].text )
    print( " -" +authors[i].text )
    quoteTags = tags[i].find_all('a',class_ = 'tag')
    for quoteTag in quoteTags:
        print(quoteTag.text)