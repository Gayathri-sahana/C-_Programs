using System;

class EmployeeAccount
{
    private int employeeId;
    private string username;
    private string password;
    private int loginAttempts;
    private bool isLocked;









































    public int EmployeeId
    {
        get { return employeeId; }
    }

    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    public EmployeeAccount(int id, string name)
    {
        employeeId = id;
        username = name;
        loginAttempts = 0;
        isLocked = false;
    }

    public void SetPassword(string password)
    {
        if (password.Length >= 8)
        {
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }

            if (hasNumber)
            {
                this.password = password;
                Console.WriteLine("Password Set Successfully");
            }
            else
            {
                Console.WriteLine("Password must contain a number");
            }
        }
        else
        {
            Console.WriteLine("Password must contain 8 characters");
        }
    }

    public bool ValidatePassword(string password)
    {
        return this.password == password;
    }

    public void Login(string username, string password)
    {
        if (isLocked)
        {
            Console.WriteLine("Account Locked");
            return;
        }

        if (this.username == username && ValidatePassword(password))
        {
            loginAttempts = 0;
            Console.WriteLine("Login Successful");
        }
        else
        {
            loginAttempts++;
            Console.WriteLine("Incorrect Password");

            if (loginAttempts == 3)
            {
                isLocked = true;
                Console.WriteLine("Account Locked");
            }
        }
    }

    public void ChangePassword(string oldPassword, string newPassword)
    {
        if (ValidatePassword(oldPassword))
        {
            SetPassword(newPassword);
        }
        else
        {
            Console.WriteLine("Old Password Incorrect");
        }
    }

    public void DisplayAccountStatus()
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Username: " + Username);

        if (isLocked)
        {
            Console.WriteLine("Account Status: Locked");
        }
        else
        {
            Console.WriteLine("Account Status: Active");
        }
    }
}

class EmployeePasswordManagement
{
    static void Main()
    {
        EmployeeAccount emp = new EmployeeAccount(101, "Arun");

        emp.SetPassword("Arun1234");

        emp.DisplayAccountStatus();

        Console.WriteLine();

        emp.Login("Arun", "Arun1234");

        Console.WriteLine();

        emp.Login("Arun", "wrong123");
        emp.Login("Arun", "wrong456");
        emp.Login("Arun", "wrong789");
    }
}