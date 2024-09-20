Matrix = []
print("This is Matrix N x N")

#Get user input and check input is digit
while True:
    try:
        n = int(input("Please input N: "))
        break
    except ValueError:
        print("Please input a valid number")

print(f"You choose Matrix {n} x {n}")


#Get input Matrix by row and verify Matrix NxN
for i in range(n):
    while True:
        row = input(f"Please input {i+1} row (Use space as delimeter): ").split()
        if len(row) == n:
            try:
                valid_row =[]
                for item in row:
                    item = float(item)
                    valid_row.append(item)
                break
            except ValueError:
                print("Please input a valid number")
        else:
            print(f"Your input have {len(row)} column on a row and Matrix are {n}x{n}")
    
    Matrix.append(valid_row)

#Calculate Matrix diagonal
def Calculate_Diagonal(matrix):
    d1 = sum(matrix[i][i] for i in range(n)) #Total Diagonal from [0][0] to [n-1][n-1]
    d2 = sum(matrix[i][n-i-1] for i in range(n)) #Total Diagonal from [0][n-1] to [n-1][0]
    return d1-d2

result = Calculate_Diagonal(Matrix)
print(f"Result: {result}")