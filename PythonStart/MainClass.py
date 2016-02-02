from datetime import datetime, date, time
from builtins import print

print("This is the notebook.")
print()
print("Today is "+ str(datetime.today()))
print()
print("    Following actions are availabe:")
print("    To check all the records in notebook type - ViewAll")
print("    To add new record type  - AddNew ")
print("    To delete existing record type - DeleteOne")
print("    To get help type - Help")
print("    To exit the notebook type - Quit")
print()

while True:
    leave = "Quit"
    print("Please type the action: ")
    action = input()
    if action == "Help":
        print()
        print("    Following actions are availabe:")
        print("    To check all the records in notebook type - ViewAll")
        print("    To add new record type  - AddNew ")
        print("    To delete existing record type - DeleteOne")
        print("    To get help type - Help")
        print("    To exit the notebook type - Quit")
        print()

    elif action==leave:
        print()
        print("See you later!")
        quit()

    elif action=="ViewAll":
        try:
            file = open('Notebook.txt','r')
        except IOError as e:
            noFile = 1
            file = open('Notebook.txt','w')
            file.close()
            print()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
            print()
        else:
            with file:
                file = open('Notebook.txt','r')
                print()
                list = [line.strip() for line in file]
                file.close()
                rowCount = len(list)#это каунтер строк в книжке
                if rowCount==0:
                    print("Notebook is empty. Add any records.")
                    print()
                else:
                    for record in list:
                        formatRecord = record.replace("|"," ")
                        print(formatRecord)
                        print()

    elif action=="AddNew":
        print()

        try:
            file = open('Notebook.txt','r')
        except IOError as e:
            noFile = 1
            file = open('Notebook.txt','w')
            file.close()
            file = open('Notebook.txt','r')
            list = [line.strip() for line in file]
            file.close()
            rowCount = len(list)

            print("Fill in the Surname:")
            surname = input()

            print("Fill in the Name:")
            name = input()

            print("Fill in the Second Name:")
            secondName = input()

            print("Fill in the Phone number(+***********):")
            phone = input()

            print("Fill in the Day of birth(dd.mm.yyyy):")
            dob = input()

            planeRecordLine = surname + " " + name + " " + secondName + " " + phone + " " + dob
            print()
            print("The following new record was added to notebook:")
            print(planeRecordLine)
            print()
            recordLine = str(rowCount) + "|" + surname + " " + name + " " + secondName + "|" + phone + "|" + dob

            file = open('Notebook.txt','a')
            file.write(recordLine + '\n')
            file.close()
            #print("Error: File with data is not found!")
            #print("*Use AddNew command to create first record in new data file")
        else:
            with file:
                file = open('Notebook.txt','r')
                list = [line.strip() for line in file]
                file.close()
                rowCount = len(list)

                print("Fill in the Surname:")
                surname = input()

                print("Fill in the Name:")
                name = input()

                print("Fill in the Second Name:")
                secondName = input()

                print("Fill in the Phone number(+***********):")
                phone = input()

                print("Fill in the Day of birth(dd.mm.yyyy):")
                dob = input()

                planeRecordLine = surname + " " + name + " " + secondName + " " + phone + " " + dob
                print()
                print("The following new record was added to notebook:")
                print(planeRecordLine)
                print()
                recordLine = str(rowCount) + "|" + surname + " " + name + " " + secondName + "|" + phone + "|" + dob

                file = open('Notebook.txt','a')
                file.write(recordLine + '\n')
                file.close()

    elif action=="DeleteOne":
        try:
            file = open('Notebook.txt','r')
        except IOError as e:
            noFile = 1
            file = open('Notebook.txt','w')
            file.close()
            print()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
            print()
        else:
            with file:
                file = open('Notebook.txt','r')
                recordList = [line.strip() for line in file]
                file.close()
                #print(list) #просто вывод списка
                rowCount = len(recordList)
                print()
                if rowCount==0:
                    print("Notebook is empty. Nothing to delete.")
                    print()
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
                        print()
                        print("Following record was removed frome notebook:")
                        print()
                        print(recordToDelete.replace("|"," "))
                        file = open('Notebook.txt','w')
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
        print()
        print("Error: No such command. Please try again.")
        print()