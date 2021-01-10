f = open('inputfile.txt', 'r')

passfile = open('passfile.txt', 'w')
failfile = open('failfile.txt', 'w')

for line in f:
    columns = line.split()
    if(columns[2] == 'P'):
        passfile.write(line)
    else:
        failfile.write(line)

f.close()
passfile.close()
failfile.close()