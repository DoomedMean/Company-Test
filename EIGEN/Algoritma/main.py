import subprocess

print("Welcome to my Project")
print("\n1. Reverse String")
print("2. Find Longest String")
print("3. Input and Query")
print("4. Matrix")
print("\nName : Welly")
print("Email: Wellytan09@gmail.com")

while True:
    
    n = input("\nPlease Choose Project: ")

    if n == "1":
        #run python file from dir (1.py)
        print('\nProject 1: Reverse String')
        subprocess.run(["python", "1.py"])
    elif n == "2":
        #run python file from dir (2.py)
        print('\nProject 2: Find Longest String')
        subprocess.run(["python", "2.py"])
    elif n == "3":
        #run python file from dir (3.py)
        print('\nProject 3: Input and Query')
        subprocess.run(["python", "3.py"])
    elif n == "4":
        #run python file from dir (4.py)
        print('\nProject 4: Matrix')
        subprocess.run(["python", "4.py"])
    else:
        print("Please enter a number from 1 to 4 only\n")