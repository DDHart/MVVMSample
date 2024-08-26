using MVVMSample.Models;
using MVVMSample.ViewModels;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace MVVMSample.Views;

public partial class AddToyPage : ContentPage
{
	//List<Toy> toys=new();//רשימת הצעצועים
 //   public List<ToyTypes> ToyTypes { get; set;} 

 //   Toy newToy;//צעצוע להוספה

 //   private string name;
 //   private double price;
 //   private string errorMessage;


 //   public bool HasError
 //   {
 //       get
 //       {
 //           return string.IsNullOrEmpty(Name)||!ValidName();
 //       }
        
 //   }



 //   public string ErrorMessage
 //   {
 //       get
 //       {
 //           return errorMessage;
 //       }
 //       set
 //       {
 //           if (errorMessage != value)
 //           {
 //               errorMessage = value;
 //               OnPropertyChanged(nameof(ErrorMessage));
 //           }
 //       }
 //   }

 //   public bool CanAddToy
 //   {
 //       get
 //       {
 //           return !HasError;
 //       }
 //   }

 //   public double Price
 //   {
 //       get
 //       {
 //           return price;
 //       }
 //       set
 //       {
 //           if (price != value)
 //           {
 //               price = value;
 //               OnPropertyChanged(nameof(Price));
 //           }
 //       }
 //   }

 //   private ToyTypes selectedType;

 //   public ToyTypes SelectedType
 //   {
 //       get
 //       {
 //           return selectedType;
 //       }
 //       set
 //       {
 //           if (selectedType != value)
 //           {
 //               selectedType = value;
 //               OnPropertyChanged(nameof(SelectedType));
 //           }
 //       }
 //   }

 //   public string Name
 //   {
 //       get
 //       {
 //           return name;
 //       }
 //       set
 //       {
 //           if (name != value)
 //           {

 //               name = value;
 //               OnPropertyChanged(nameof(Name));
 //               HandleError();
               
 //           }

 //       }
 //   }

 //   private void HandleError()
 //   {
 //       if (!ValidName())
 //       {
 //           ErrorMessage = "שם קצר מידי או מכיל ערכים לא תקינים";
 //       }
 //       else
 //           ErrorMessage = string.Empty;
 //       OnPropertyChanged(nameof(HasError));
 //       OnPropertyChanged(nameof(CanAddToy));
 //   }

    public AddToyPage()
	{
        //ToyTypes = new List<ToyTypes>();
        //ToyTypes.Add(new ToyTypes() { Id=1, Name="פאזל"});
        //ToyTypes.Add(new ToyTypes() { Id=2, Name="משחקי חשיבה"});
        //ToyTypes.Add(new ToyTypes() { Id=3, Name="בובה"});

		InitializeComponent();
        BindingContext = new AddToysPageViewModel();
       
	}



    //#region Implement Valid Checks
    ////1. name Should start Capital letter, at lease 4 letter word
    ////Regex: ^[A-Z][a-zA-Z]{3,}
    ////sample Prompt used in claude:
    ///*
    // * אני צריך REGEX expression עבור מחרוזת בעלת אילוצים הבאים: 
    // * 1. חייבת להתחיל באות גדולה
    // * 2. לפחות 4 אותיות
    // * כתוב גם מקרי קצה שיש לבדוק שאכן תקין 3. 
    // * 4. המלץ על אתרים בהם ניתן לבדוק אותו.
    // * השימוש יעשה בשפת C# */
    //private bool ValidName()
    //{
    //    Regex reg = new Regex(@"^[A-Z][a-zA-Z]{3,}$");
    //    return reg.IsMatch(Name);
    //}
    //#endregion

    #region Implement אירוע הוספת צעצוע
    //אם חדש - המחיר יישאר כפי שהוא
    //אם משומש - 10% הנחה
    #endregion

    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    Button btn = sender as Button;
    //    newToy = new Toy() { Id = 1, Name = this.Name, Price = this.Price, Type = SelectedType };
    //    if (btn.Text == "הוסף צעצוע")
    //        newToy.IsSecondHand = false;
    //    else
    //    {
    //        newToy.IsSecondHand = true;
    //        newToy.Price = newToy.Price * 0.9;
    //    }
    //        toys.Add(newToy);
        

    
       
}