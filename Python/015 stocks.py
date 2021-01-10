import yfinance as yf
import time
from tabulate import tabulate
my_ticker_watch_list = ["MSFT", "AAPL"]
my_ticker_watch_list.sort()
my_ticker_watch_string = " ".join(my_ticker_watch_list)
length_of_tickers = len(my_ticker_watch_list)

while True:
    tickers = yf.Tickers(my_ticker_watch_string)
    headers = ("symbol", "company", "Open", "Current", "200DayAverage", "52weeklo",
               "52weekhi", "% Less than Opening", "% Less than 52-week hi", "% Less than 200-day hi")
    data_list = []

    # stock_info = yf.Ticker("NIO")
    # print(stock_info.info)

    for stock_index in range(0, length_of_tickers):
        stock_info = tickers.tickers[stock_index].info
        company = stock_info["shortName"]

        print(company)
        symbol = stock_info["symbol"]
        open_price = stock_info['regularMarketOpen']
        if open_price is None:
            open_price = stock_info["previousClose"]
        current_price = stock_info["ask"]
        if current_price is None:
            current_price = stock_info["previousClose"]
        fifty_two_week_high = stock_info["fiftyTwoWeekHigh"]
        fifty_two_week_low = stock_info["fiftyTwoWeekLow"]
        two_hundred_day_average = stock_info["twoHundredDayAverage"]

        if two_hundred_day_average is not None:
            two_hundred_day_average = round(two_hundred_day_average, 2)

        percent_less_than_200day = round(
            (two_hundred_day_average - current_price) * 100/two_hundred_day_average, 2)
        if percent_less_than_200day < 0:
            percent_less_than_200day = 0

        percent_less_than_open_price = round(
            (open_price - current_price) * 100/open_price, 2)
        if percent_less_than_open_price < 0:
            percent_less_than_open_price = 0

        percent_less_than_52week_high = round(
            (fifty_two_week_high - current_price) * 100/fifty_two_week_high, 2)
        if percent_less_than_52week_high < 0:
            percent_less_than_52week_high = 0

        if True or percent_less_than_52week_high > 14.9 or percent_less_than_open_price > 14.9 or percent_less_than_200day > 14.9:
            data_tuple = (symbol, company, open_price, current_price, two_hundred_day_average, fifty_two_week_low,
                          fifty_two_week_high, percent_less_than_open_price, percent_less_than_52week_high, percent_less_than_200day)
            data_list.append(data_tuple)

        # print("symbol: " + symbol)
        # print("company: " + company)
        # print("open_price: " + str(open_price))
        # print("current_price: " + str(current_price))
        # print("fifty_two_week_high: " + str(fifty_two_week_high))
        # print("fifty_two_week_low: " + str(fifty_two_week_low))
        # print("")

    print(tabulate(data_list, headers=headers))
    # time.sleep(900)
    break
