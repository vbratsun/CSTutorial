import os.path

class RecordStructure:

    def __init__(self):
        pass

    def getRecordId(self):
        return self.recordId

    def setRecordId(self, value):
        self.recordId = value



    def getUserName(self):
        return self.userName

    def setUserName(self, value):
        self.userName = value



    def getUserPhoneNumber(self):
        return self.userPhoneNumber

    def setUserPhoneNumber(self, value):
        self.userPhoneNumber = value

    def getUserDob(self):
        return self.userDob

    def setUserDob(self, value):
        self.userDob = value

class AdressBookActions:

    def __init__(self, filename):
        self.fileName = filename

    def loadFromFile(self):
        self.records = []
        file = open(self.fileName,'r')
        data = file.read()
        recordLines = data.splitlines()
        #self.records = []
        for recordLine in recordLines:
            recordFields = recordLine.split("|")
            if len(recordFields) == 6:
                record = RecordStructure()
                record.id = recordFields[0]
                record.surname = recordFields[1]
                record.name = recordFields[2]
                record.fathersName = recordFields[3]
                record.phone = recordFields[4]
                record.dob = recordFields[5]
                self.records.append(record)

class UserActions:
    def doActionAllRecords():
        for record in adressBookActions.records:
            print(record.id + "|" + record.surname + "|" + record.name + "|" + record.secondName + "|" + record.phone + "|" + record.dob + "|")


adressBookActions = AdressBookActions("NotebookTest.txt")

adressBookActions.loadFromFile()

while True:
    print("Please type the action: ")
    action = input()

    if action.lower() == "all":
        UserActions.doActionAllRecords()

    else:
        print("Error: No such command. Please try again.")