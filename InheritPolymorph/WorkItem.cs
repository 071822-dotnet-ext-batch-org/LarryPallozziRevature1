using System;

namespace polyinherit
{
  // WorkItem implicitly inherits from the Object class.
  public class WorkItem
  {
    // Static field currentID stores the job ID of the last WorkItem that
    // has been created.
    private static int currentID;

    //Properties.
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }

    // Default constructor. If a derived class does not invoke a base-
    // class constructor explicitly, the default constructor is called
    // implicitly.
    public WorkItem()
    {
      ID = 0;
      Title = "Default title";
      Description = "Default description.";
      jobLength = new TimeSpan();
    }

    // Instance constructor that has three parameters.
    public WorkItem(string title, string desc, TimeSpan joblen)
    {
      this.ID = GetNextID();
      this.Title = title;
      this.Description = desc;
      this.jobLength = joblen;
    }

    // Static constructor to initialize the static member, currentID. This
    // constructor is called one time, automatically, before any instance
    // of WorkItem or ChangeRequest is created, or currentID is referenced.
    static WorkItem() => currentID = 0;

    // currentID is a static field. It is incremented each time a new
    // instance of WorkItem is created.
    protected int GetNextID() => ++currentID;

    // Method Update enables you to update the title and job length of an
    // existing WorkItem object.
    public void Update(string title, TimeSpan joblen)
    {
      this.Title = title;
      this.jobLength = joblen;
    }

    // Virtual method override of the ToString method that is inherited
    // from System.Object.
    public override string ToString() =>
        $"{this.ID} - {this.Title}";
  }

  // ChangeRequest derives from WorkItem and adds a property (originalItemID)
  // and two constructors.
  public class ChangeRequest : WorkItem
  {
    protected int originalItemID { get; set; }

    // Constructors. Because neither constructor calls a base-class
    // constructor explicitly, the default constructor in the base class
    // is called implicitly. The base class must contain a default
    // constructor.

    // Default constructor for the derived class.
    public ChangeRequest() { }

    // Instance constructor that has four parameters.
    public ChangeRequest(string title, string desc, TimeSpan jobLen,
                         int originalID)
    {
      // The following properties and the GetNexID method are inherited
      // from WorkItem.
      this.ID = GetNextID();
      this.Title = title;
      this.Description = desc;
      this.jobLength = jobLen;

      // Property originalItemId is a member of ChangeRequest, but not
      // of WorkItem.
      this.originalItemID = originalID;
    }
  }
}
