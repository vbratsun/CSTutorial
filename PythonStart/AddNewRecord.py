print("enter new record in format: Surname Name Father's name, Phone +xxxxxxxxxxx, day of birth dd.mm.yyyy ")

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

recordLine = surname + " " + name + " " + secondName + "| " + phone + "| " + dob
print("The following new record will be added to notebook:")
print(recordLine)

file = open('NotebookTest.txt','w')

file.write(recordLine)
file.close()