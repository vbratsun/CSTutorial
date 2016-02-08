from datetime import datetime, date, time
from builtins import print

notebookFile = 'ZZZ.txt'


def fileExistCheck(n):
    try:
        file = open(notebookFile,'r')
    except IOError as e:
        file = open(notebookFile,'w')
        file.close()
        print("Error: File with data is not found!")
        print("*Use AddNew command to create first record in new data file")
        return 0
    else:
        with file:
            return notebookFile

def fileIsEmpty(n):
    file = open(notebookFile,'r')
    singleLine = [line.strip() for line in file]
    file.close()
    rowCount = len(singleLine)
    print()
    if rowCount==0:
        print("Notebook is empty.")
        return 0
    else:
     return singleLine

def main():
    print(date.today())
    print("To check if anyone has birthday type - Bday")

    while True:
        action = input()
        expected = "Bday"
        if expected == action:
            if fileExistCheck(notebookFile)!=0:
                birthdayCounter=0
                dateToday=str(date.today())
                partOfDate = dateToday[4:10]
                if fileIsEmpty(notebookFile)!=0:
                    for record in singleLine:
                        if partOfDate in record:
                            birthdayCounter=birthdayCounter+1
                            print(record.replace("|"," "))

                    if birthdayCounter==0:
                        print("No one has birthday today.")
                        print()




        else:
            print("Error: No such command. Please try again.")

main()