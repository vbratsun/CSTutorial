print("enter new record in format: Surname Name Father's name, Phone +xxxxxxxxxxx, day of birth dd.mm.yyyy ")

record = input()
file = open('Notebook.txt','w')

file.write(record + ";")
file.close()