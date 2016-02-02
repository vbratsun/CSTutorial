print("enter new record in format: Surname Name Father's name, Phone +xxxxxxxxxxx, day of birth dd.mm.yyyy ")

while True:
    print("Please type the action: ")
    action = input()
    expected = "AddNew"
    if expected==action:
        try:
            file = open('NotebookTest.txt','r')
        except IOError as e:
            noFile = 1
            file = open('NotebookTest.txt','w')
            file.close()
            file = open('NotebookTest.txt','r')
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

            file = open('NotebookTest.txt','a')
            file.write(recordLine + '\n')
            file.close()
            #print("Error: File with data is not found!")
            #print("*Use AddNew command to create first record in new data file")
        else:
            with file:
                file = open('NotebookTest.txt','r')
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

                file = open('NotebookTest.txt','a')
                file.write(recordLine + '\n')
                file.close()

    else:
        print("Error: No such command. Please try again.")