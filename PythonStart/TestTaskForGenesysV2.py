import os.path

class RecordStructure:

    def __init__(self):
        pass

    def getRecordId(self):
        return self.recordId

    def setRecordId(self, value):
        self.recordId = value

    def getUserSurname(self):
        return self.userSurname

    def setUserSurname(self, value):
        self.userSurname = value

    def getUserName(self):
        return self.userName

    def setUserName(self, value):
        self.userName = value

    def getUserFathersName(self):
        return self.userFathersName

    def setUserFathersName(self, value):
        self.userFathersName = value

    def getUserPhoneNumber(self):
        return self.userPhoneNumber

    def setUserPhoneNumber(self, value):
        self.userPhoneNumber = value

    def getUserDob(self):
        return self.userDob

    def setUserDob(self, value):
        self.userDob = value


class AddressBookActions:

    def __init__(self, filename):
        self.fileName = filename

    def addRecord(self, record):
        self.records.append(record)
        self.saveToFile()

    def loadFromFile(self):
        self.records = []
        file = open(self.fileName,'r')
        data = file.read()
        file.close()
        recordLines = data.splitlines()
        for recordLine in recordLines:
            recordFields = recordLine.split("|")
            if len(recordFields) == 6:
                record = RecordStructure()
                record.recordId = recordFields[0]
                record.userSurname = recordFields[1]
                record.userName = recordFields[2]
                record.userFathersName = recordFields[3]
                record.userPhoneNumber = recordFields[4]
                record.userDob = recordFields[5]
                self.records.append(record)

    def saveToFile(self):
        file = open(self.fileName,'w')
        for record in self.records:
            file.write(str(record.recordId) + "|" + record.userSurname + "|" + record.userName + "|" + record.userFathersName + "|" + record.userPhoneNumber + "|" + record.userDob + "\n")
        file.close()

    def createFile(self):
        file = open(self.fileName,'w')
        file.close()

    def getNextId(self):
        max = 0
        for record in self.records:
            if max < record.recordId:
                max = record.recordId
        return max + 1

    def getNumberOfRows(self):
        return len(self.records)


def doActionLeave():
    print()
    print("See you later!")
    quit()

def doActionHelp():
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

def doActionGetAllRecords():
    addressBookActions.loadFromFile()
    for record in addressBookActions.records:
        print(str(record.recordId) + "|" + record.userSurname + "|" + record.userName + "|" + record.userFathersName + "|" + record.userPhoneNumber + "|" + record.userDob)

def doActionAddNewRecord():
    addressBookActions.loadFromFile()

    record = RecordStructure()

    count = addressBookActions.getNumberOfRows()
    record.setRecordId(count)

    print("Fill in the Surname:")
    record.setUserSurname(input())

    print("Fill in the Name:")
    record.setUserName(input())

    print("Fill in the Fathers Name:")
    record.setUserFathersName(input())

    print("Fill in the Phone number(+***********):")
    record.setUserPhoneNumber(input())

    print("Fill in the Day of birth(yyyy-mm-dd):")
    record.setUserDob(input())
    addressBookActions.addRecord(record)

def doActionClearAddressbook():
    addressBookActions.createFile()

def doActionFindRecord():
    addressBookActions.loadFromFile()
    print("insert search text:")
    searchText = input()
    result = []
    for record in addressBookActions.records:
        recorAsString = str(record.recordId) + "|" + record.userSurname + "|" + record.userName + "|" + record.userFathersName + "|" + record.userPhoneNumber + "|" + record.userDob
        recorAsString = str(recorAsString).lower()
        if searchText in recorAsString:
            result.append(record)

    for record in result:
        print(str(record.recordId) + "|" + record.userSurname + "|" + record.userName + "|" + record.userFathersName + "|" + record.userPhoneNumber + "|" + record.userDob)

#main section start

addressBookActions = AddressBookActions("NotebookV2.txt")

while True:
    print("Please type the action: ")
    action = input()

    if action.lower() == "all":
        doActionGetAllRecords()
    elif action.lower() == "add":
        doActionAddNewRecord()
    elif action.lower() == "clear":
        doActionClearAddressbook()
    elif action.lower() == "find":
        doActionFindRecord()
    elif action.lower() == "quit":
        doActionLeave()
    elif action.lower() == "help":
        doActionHelp()
    else:
        print("Error: No such command. Please try again.")