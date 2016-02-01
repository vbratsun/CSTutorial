print ("To check all the records in notebook type - ViewAll")
while True:
    viewAll = input()
    expected = "ViewAll"
    if expected==viewAll:
        file = open('Notebook.txt','r')
        print(file.read())
        file.close()
        break
    else:
        print("Error: No such command. Please try again.")