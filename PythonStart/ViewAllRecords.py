print ("To check all the records in notebook type - ViewAll")
viewAll = input()
expected = "ViewAll"
if viewAll==expected:
    file = open('Notebook.txt','r')
    print(file.read())
    file.close()
else:
    print("Error: No such command")