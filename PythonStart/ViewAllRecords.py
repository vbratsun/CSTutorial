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
            file.write(record.recordId + "|" + record.userSurname + "|" + record.userName + "|" + record.userFathersName + "|" + record.userPhoneNumber + "|" + record.userDob + "\n")
        file.close()

    def createFile(self):
        file = open(self.fileName,'w')
        file.close()

    def getNumberOfRows(self):
        self.records = []
        file = open(self.fileName,'r')
        data = file.read()
        file.close()
        recordLines = data.splitlines()
        self.rowCount = len(recordLines)

def doActionGetAllRecords():
    for record in addressBookActions.records:
        print(record.recordId + "|" + record.userSurname + "|" + record.userName + "|" + record.userFathersName + "|" + record.userPhoneNumber + "|" + record.userDob)

def doActionAddNewRecord():
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

addressBookActions = AddressBookActions("NotebookTest.txt")
addressBookActions.loadFromFile()

while True:
    print("Please type the action: ")
    action = input()

    if action.lower() == "all":
        doActionGetAllRecords()
    elif action.lower() == "add":
        doActionAddNewRecord()
    else:
        print("Error: No such command. Please try again.")