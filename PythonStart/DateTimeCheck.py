from datetime import datetime, date, time
from builtins import print


def main():
    print(date.today())
    print("To check if anyone has birthday type - Bday")

while True:
    action = input()
    expected = "Bday"
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
                #print(list) #просто вывод списка
                rowCount = len(list)
                print()
                if rowCount==0:
                    print("Notebook is empty.")
                else:
                    birthdayCounter=0
                    dateToday=str(date.today())
                    partOfDate = dateToday[4:10]

                    for record in list:
                        if partOfDate in record:
                            birthdayCounter=birthdayCounter+1
                            print(record.replace("|"," "))

                    if birthdayCounter==0:
                        print("No one has birthday today.")
                        print()

    else:
        print("Error: No such command. Please try again.")
