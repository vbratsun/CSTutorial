print ("To check all the records in notebook type - ViewAll")
while True:
    viewAll = input()
    expected = "ViewAll"
    if expected==viewAll:
        try:
            file = open('Notebook.txt','r')
        except IOError as e:
            print("Error: Notebook file is not found!")
        else:
            with file:
                file = open('Notebook.txt','r')
                list = [line.strip() for line in file]
                file.close()
                #print(list) #просто вывод списка
                print()
                for record in list:#вывод списка построчно
                    formatRecord = record.replace("|"," ")
                    print(formatRecord)

    else:
        print("Error: No such command. Please try again.")