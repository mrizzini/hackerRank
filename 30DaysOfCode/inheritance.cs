class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    
    public Student(string firstName, string lastName, int id, int[] TestScores)
        : base(firstName, lastName, id)
    {       
        testScores = TestScores;
    }
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    
    public string Calculate() 
    {
        int sum = 0;
        string grade = "";
        
        foreach (var score in testScores)
        {
            sum += score;
        }
        
        var average = sum / testScores.Length;
        
        if (average < 40)
        {
            grade = "T";
        }
        else if (average >= 40 && average < 55)
        {
            grade = "D";
        }
        else if (average >= 55 && average < 70)
        {
            grade = "P";
        }
        else if (average >= 70 && average < 80)
        {
            grade = "A";
        }
        else if (average >= 80 && average < 90)
        {
            grade = "E";
        }
        else if (average >= 90 && average <= 100)
        {
            grade = "O";
        }
        
        return grade;
    }
}