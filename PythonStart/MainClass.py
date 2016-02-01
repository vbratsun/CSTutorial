from builtins import print

print("This is the notebook.")
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
        file = open('Notebook.txt','r')
        print()
        print(file.read())
        print()
        file.close()

    elif action=="AddNew":
        print()

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
        recordLine = surname + " " + name + " " + secondName + "|" + phone + "|" + dob
        print()
        print("The following new record will be added to notebook:")
        print(planeRecordLine)
        print()

        file = open('Notebook.txt','w')
        file.write(recordLine)
        file.close()

    else:
        print()
        print("Error: No such command. Please try again.")
        print()