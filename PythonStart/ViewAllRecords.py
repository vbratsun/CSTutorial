from datetime import datetime, date, time

print(datetime.today())

print ("To check all the records in notebook type - ViewAll")
while True:
    viewAll = input()
    expected = "ViewAll"
    if expected==viewAll:
        try:
            file = open('Notebook.txt','r')
        except IOError as e:
            noFile = 1
            file = open('Notebook.txt','w')
            file.close()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
        else:
            with file:
                file = open('Notebook.txt','r')
                list = [line.strip() for line in file]
                file.close()
                #print(list) #просто вывод списка
                rowCount = len(list)
                print()
                if rowCount==0:
                    print("Notebook is empty.")
                else:
                    for record in list:#вывод списка построчно
                        formatRecord = record.replace("|"," ")
                        print(formatRecord)

    else:
        print("Error: No such command. Please try again.")