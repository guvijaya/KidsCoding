import requests
from bs4 import BeautifulSoup

url = 'https://scrapingclub.com/exercise/list_basic/'
responses = requests.get(url)
soup = BeautifulSoup(responses.text, 'lxml')
items = soup.find_all('div', class_='col-lg-4 col-md-6 mb-4')

pages = soup.find('ul', class_='pagination')
links = pages.find_all('a', class_='page-link')
urls = []
for link in links:
    pagenum = int(link.text) if link.text.isdigit() else None
    if(pagenum != None):
        x = link.get('href')  
        urls.append(x)

for querystring in urls:
        url = 'https://scrapingclub.com/exercise/list_basic/'
        responses = requests.get(url+querystring)
        soup = BeautifulSoup(responses.text, 'lxml')
        items = soup.find_all('div', class_='col-lg-4 col-md-6 mb-4')

        for item in items:
            itemname = item.find('h4','card-title').text.strip('\n')
            price = item.find('h5').text
            print("Name: %s - Price: %s" % (itemname, price))