from datetime import datetime, date, time
from builtins import print
from _ast import Try
import os.path
import re

class AdressBookActions:
    #def __init__(self, filename):
    #    self.fileName = filename

    def getHelp():
        print()
        print("Following actions are availabe:")
        print("    To check all the records in notebook type - ViewAll")
        print("    To add new record type  - AddNew ")
        print("    To delete existing record type - DeleteOne")
        print("    To find record in notebook type - FindOne")
        print("    To check if anyone has birthday type - Bday")
        print("    To clear the notebook type - Clear")
        print("    To get help type - Help")
        print("    To exit the notebook type - Quit")
        print()

    def leave():
        print()
        print("See you later!")
        quit()

    def viewAllRecords():
        try:
            file = open(_fileName,'r')
        except IOError as e:
            file = open(_fileName,'w')
            file.close()
            print()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
            print()
        else:
            with file:
                file = open(_fileName,'r')
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

    def addNewRecord():
        print()

        try:
            file = open(_fileName,'r')
        except IOError as e:
            file = open(_fileName,'w')
            file.close()
            file = open(_fileName,'r')
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

            print("Fill in the Day of birth(yyyy-mm-dd):")
            dob = input()

            planeRecordLine = surname + " " + name + " " + secondName + " " + phone + " " + dob
            print()
            print("The following new record was added to notebook:")
            print(planeRecordLine)
            print()
            recordLine = str(rowCount) + "|" + surname + " " + name + " " + secondName + "|" + phone + "|" + dob

            file = open(_fileName,'a')
            file.write(recordLine + '\n')
            file.close()

        else:
            with file:
                file = open(_fileName,'r')
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

                print("Fill in the Day of birth(yyyy-mm-dd):")
                dob = input()

                planeRecordLine = str(rowCount) + " " + surname + " " + name + " " + secondName + " " + phone + " " + dob
                print()
                print("The following new record was added to notebook:")
                print(planeRecordLine)
                print()
                recordLine = str(rowCount) + "|" + surname + " " + name + " " + secondName + "|" + phone + "|" + dob

                file = open(_fileName,'a')
                file.write(recordLine + '\n')
                file.close()

    def deleteOneRecord():
        try:
            file = open(_fileName,'r')
        except IOError as e:
            file = open(_fileName,'w')
            file.close()
            print()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
            print()
        else:
            with file:
                file = open(_fileName,'r')
                recordList = [line.strip() for line in file]
                file.close()
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
                    try:
                        deleteRowNumber = int(input())
                    except ValueError as e:
                        print()
                        print("Only integer is allowed!")
                        print()
                    else:
                        if deleteRowNumber >= 0 and deleteRowNumber < rowCount:
                            updatedRecordList = recordList
                            recordToDelete = updatedRecordList.pop(deleteRowNumber)
                            print()
                            print("Following record was removed frome notebook:")
                            print(recordToDelete.replace("|"," "))
                            print()
                            file = open(_fileName,'w')
                            i=-1
                            for record in updatedRecordList:
                                i=i+1
                                subRecord = record.split("|")
                                subRecord.__delitem__(0)
                                subRecord.insert(0,str(i))
                                file.write("|".join(subRecord) + '\n')
                            file.close()
                        else:
                            print()
                            print("No record with such number")
                            print()

    def getBirthDays():
        try:
            file = open(_fileName,'r')
        except IOError as e:
            file = open(_fileName,'w')
            file.close()
            print()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
            print()
        else:
            with file:
                file = open(_fileName,'r')
                list = [line.strip() for line in file]
                file.close()
                rowCount = len(list)
                if rowCount==0:
                    print("Notebook is empty. No birthdays to display.")
                    print()
                else:
                    birthdayCounter=0
                    dateToday=str(date.today())
                    partOfDate = dateToday[4:10]
                    bdayList = ""

                    for record in list:
                        if partOfDate in record:
                            birthdayCounter=birthdayCounter+1
                            bdayList = bdayList +"\n"+ record.replace("|"," ")
                    print("Following people have birthday today:")
                    print(bdayList)
                    print()

                    if birthdayCounter==0:
                        print("No one has birthday today.")
                        print()

    def findOneRecord():
        try:
            file = open(_fileName,'r')
        except IOError as e:
            file = open(_fileName,'w')
            file.close()
            print("Error: File with data is not found!")
            print("*Use AddNew command to create first record in new data file")
        else:
            with file:
                file = open(_fileName,'r')
                list = [line.strip() for line in file]
                file.close()
                rowCount = len(list)
                print()
                if rowCount==0:
                    print("Notebook is empty.")
                else:
                    counter=0
                    print("Type text to search:")
                    searchText=str(input()).lower()
                    print()
                    for record in list:
                        modRecord = str(record).lower()
                        if searchText in modRecord:
                            counter=counter+1
                            print(record.replace("|"," "))

                    if counter==0:
                        print("Nothing is found.")
                        print()

    def clearAdressBook():
        file = open(_fileName,'w')
        file.close()
        print()
        print("All records were removed from notebook.")
        print()

class AppHeader:
    def inform():
        print("This is the notebook.v0.2")
        print()
        print("Today is "+ str(date.today()))
        AdressBookActions.getHelp()
        print()

_fileName = "Notebook.txt"

AppHeader.inform()
AdressBookActions.getBirthDays()

while True:
    print("Please type the action: ")
    action = input()

    if action.lower()=="quit":
        AdressBookActions.leave()
    elif action.lower()=="help":
        AdressBookActions.getHelp()
    elif action.lower()=="viewall":
        AdressBookActions.viewAllRecords()
    elif action.lower()=="addnew":
        AdressBookActions.addNewRecord()
    elif action.lower()=="deleteone":
        AdressBookActions.deleteOneRecord()
    elif action.lower()=="findone":
        AdressBookActions.findOneRecord()
    elif action.lower()=="bday":
        AdressBookActions.getBirthDays()
    elif action.lower()=="clear":
        AdressBookActions.clearAdressBook()
    else:
        print()
        print("Error: No such command. Please try again.")
        print()