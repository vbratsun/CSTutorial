import os.path
import re
from _ast import Try

class AddressBookRecord:
    def __init__(self):
        pass    
    
    def getName(self):
        return self.name
    
    def setName(self, value):
        self.name = value
    
    def setPhone(self, value):
        rule = re.compile(r'(^[+0-9]{1,3})*([0-9]{10,11}$)')
        if rule.search(value):
            self.phone = value
        else:
            raise ValueError('Invalid phone number')

    
class AddressBook:
    
    def __init__(self, filename):
        self.fileName = filename
    
    def add(self, record):
        self.records.append(record)
        self.saveToFile()
    
    def loadFromFile(self):
        self.records = []
        if not os.path.isfile(self.fileName):
            return True
        
        if not os.access(self.fileName, os.R_OK):
            print("File is not readable")
            return False
        
        try:
            with open(self.fileName, 'r') as file:                
                data = file.read()
                recordLines = data.splitlines()
                self.records = []
                for recordLine in recordLines:
                    recordFields = recordLine.split("|")
                    if len(recordFields) == 5:
                        record = AddressBookRecord()
                        record.surname = recordFields[0]
                        record.name = recordFields[1]
                        record.secondName = recordFields[2]
                        record.phone = recordFields[3]
                        record.dob = recordFields[4]                        
                        self.records.append(record)
            return True
        except Exception as e:
            print("Error while trying read file: " + e.message)
            return False
        
    def saveToFile(self):
        try:
            with open(self.fileName, 'w') as file:
                for record in self.records:
                    file.write(record.surname + "|" + record.name + "|" + record.secondName + "|" + record.phone + "|" + record.dob + "\n")
            
        except:
            print("Error while trying read file")


def doActionAddRecord():
    record = AddressBookRecord()
    
    print("Fill in the Surname:")
    record.surname = input()

    print("Fill in the Name:")
    record.setName(input()) 

    print("Fill in the Second Name:")
    record.secondName = input()

    print("Fill in the Phone number(+***********):")
    try:
        record.setPhone(input())
    except Exception as e:
        print(e)
        return        

    print("Fill in the Day of birth(yyyy-mm-dd):")
    record.dob = input()
    
    addressBook.add(record)

def doActionAllRecords():
    for record in addressBook.records:
        print(record.surname + "|" + record.name + "|" + record.secondName + "|" + record.phone + "|" + record.dob + "|")
    

addressBook = AddressBook("Notebook.txt")
#addressBook.loadFromFile()
if not addressBook.loadFromFile():
    quit()

while True:
    print("Please type the action: ")
    action = input()
    
    if action.lower() == "add":
        doActionAddRecord()
    elif action.lower() == "all":
        doActionAllRecords()
    elif action.lower() == "quit":
        quit()
    else:
        print("Unknown command")
        