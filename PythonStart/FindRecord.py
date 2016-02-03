print("To find record in notebook type - FindOne")

while True:
    action = input()
    expected = "FindOne"
    if expected == action:
        try:
            file = open('NotebookTest.txt','r')
        except IOError as e:
            file = open('NotebookTest.txt','w')
            file.close()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
        else:
            with file:
                file = open('NotebookTest.txt','r')
                list = [line.strip() for line in file]
                file.close()
                rowCount = len(list)
                print()
                if rowCount==0:
                    print("Notebook is empty.")
                else:
                    counter=0
                    print("Type exact name:")
                    searchText=str(input()).lower()

                    for record in list:
                        modRecord = str(record).lower()

                        if searchText in modRecord:
                            counter=counter+1
                            print(record.replace("|"," "))

                    if counter==0:
                        print("Nothing is found.")
                        print()

    else:
        print("Error: No such command. Please try again.")
