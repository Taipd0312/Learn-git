using (resource)
{
    /// <summary>
    /// Gets or sets the name of the resource
    /// <summary>
    resource.Release;
    #region namespace
        hello = resource.GetType().GetGenericArguments().FirstOrDefault();
    #endregion

    public static void main(string[] args)
    {
        var student = "student 1";
        Console.writelines(student);
    }

    public static void GetStudent(string student)
    {
        return "GetStudent";
    }

    public static void SetStudent(string student, string value) => SetStudent(student, value);

    public static bool IsStudent(string student) => IsStudent(student);

    public static bool IsInClassroom(string student) => IsInClassroom(student);
}