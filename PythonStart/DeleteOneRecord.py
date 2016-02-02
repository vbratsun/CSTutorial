print ("To delete existing record type - DeleteOne")
while True:
    action = input()
    expected = "DeleteOne"
    if expected==action:
        try:
            file = open('NotebookTest.txt','r')
        except IOError as e:
            noFile = 1
            file = open('NotebookTest.txt','w')
            file.close()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
        else:
            with file:
                file = open('NotebookTest.txt','r')
                recordList = [line.strip() for line in file]
                file.close()
                #print(list) #просто вывод списка
                rowCount = len(recordList)
                print()
                if rowCount==0:
                    print("Notebook is empty.")
                else:
                    for record in recordList:#вывод списка построчно
                        formatRecord = record.replace("|"," ")
                        print(formatRecord)
                        print()
                    print("Enter the number of record to delete:")
                    deleteRowNumber = int(input())

                    if deleteRowNumber >= 0 and deleteRowNumber < rowCount:
                        updatedRecordList = recordList
                        recordToDelete = updatedRecordList.pop(deleteRowNumber)
                        print("Following record was removed frome notebook:")
                        print(recordToDelete.replace("|"," "))
                        file = open('NotebookTest.txt','w')
                        i=-1
                        for record in updatedRecordList:
                            i=i+1
                            subRecord = record.split("|")
                            subRecord.__delitem__(0)
                            subRecord.insert(0,str(i))
                            file.write("|".join(subRecord) + '\n')

                        file.close()
                    else:
                        print("No record with such number")

    else:
        print("Error: No such command. Please try again.")