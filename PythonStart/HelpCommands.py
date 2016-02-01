print ("To get help type - Help")
while True:
    help = input()
    expected = "Help"
    if expected==help:
        print ("Following actions are availabe:")
        print ("To check all the records in notebook type - ViewAll")
        print ("To add new record type  - AddNew ")
        print ("To delete existing record type - DeleteOne")
        print ("To get help type - Help")
        print ("To exit the notebook type - Quit")
        break
    else:
        print("Error: No such command. Please try again.")