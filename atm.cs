import java.util.Scanner;
public class ATM {

  public static void main(String[] args) {
  Scanner SC = new Scanner(System.in);
   String PIN = "1234";
   System.out.println("Enter PIN");
   String SPIN = SC.nextLine();
   cls();
   
   if ( SPIN.equals(PIN))
   {
     MAINMENU();
   }
   else
    {
      System.out.println("INVALID PIN NUMBER");
    }
  }
public static void MAINMENU()
{
          Scanner SC = new Scanner(System.in);
          
          System.out.println("\n_______________________________________________________");
          System.out.println("1 - WITHDRAW");
          System.out.println("2 - BALANCE");
          System.out.println("3 - EXIT");
          int x = SC.nextInt();
          cls();
          
          if ( x == 1 )
           {
           WITHDRAW();
           }
          else if ( x == 2 )
           {
           BALANCE();
           }
          else if ( x == 3 )
           {
           System.out.println("THANKYOU!!!");
           }
          else
           {
          System.out.println("INVALID INPUT");
           }
}
public static void WITHDRAW()
{
          Scanner SC = new Scanner(System.in);
          
          System.out.println("\n_______________________________________________________");
          System.out.println("1 - SAVINGS ACCOUNT");
          System.out.println("2 - CHECKING ACCOUNT");
          System.out.println("3 - CREDIT CARD ACCOUNT");
          int x = SC.nextInt();
          cls();
          
          if ( x == 1 )
           {
           WITHDRAW1();
           }
          else if ( x == 2 )
           {
           WITHDRAW2();
           }
          else if ( x == 3 )
           {
           WITHDRAW3();
           }
          else
           {
          System.out.println("INVALID INPUT");
           }
}
public static void WITHDRAW1()
{
          Scanner SC = new Scanner(System.in);
          System.out.println("\n_______________________________________________________");
          System.out.println("SAVINGS ACCOUNT");
          System.out.println("DO YOU WISH TO CONTINUE?Y/N");
          String a = SC.nextLine();
          cls();
          if (a.equalsIgnoreCase("Y"))
          {
          	WITHDRAW1l();
          }
          else if (a.equalsIgnoreCase("N"))
          {
          	MAINMENU();
          }        
}
public static void WITHDRAW1l()
{
	{
	  	Scanner SC = new Scanner(System.in);
          double SAVINGS = 30000;
          double CC = 40000;
          double ACC = SAVINGS + CC;
		System.out.println("HOW MUCH WOULD YOU LIKE TO WITHDRAW?");
          double x = SC.nextDouble();
          cls();
          
          if(x <= SAVINGS )
          {
          	System.out.println("PLEASE COUNT THE AMOUNT\n \tBEFORE YOU LEAVE");
          	System.out.println("\n_______________________________________________________");
          	
          }
          else if (x > SAVINGS )
          {
          	System.out.println("YOUR BALANCE IS NOT ENOUGH\nPLEASE CHECK YOUR BALANCE");
          	
          	System.out.println("\n_______________________________________________________");
          	
          }
          }
          {
         Scanner SC = new Scanner(System.in); 
          System.out.println("WOULD YOU LIKE TO TRANSACT AGAIN?Y/N");
          String y = SC.nextLine();
         cls();
          
          if ( y.equalsIgnoreCase("Y"))
           {
           MAINMENU();
           }
          else if ( y.equalsIgnoreCase("N"));
           {
           System.out.println("THANKYOU!!!");
           }
	}
}
public static void WITHDRAW2()
{
          Scanner SC = new Scanner(System.in);
          System.out.println("\n_______________________________________________________");
          System.out.println("SAVINGS ACCOUNT");
          System.out.println("DO YOU WISH TO CONTINUE?Y/N");
          String a = SC.nextLine();
          cls();
          if (a.equalsIgnoreCase("Y"))
          {
          	WITHDRAW2l();
          }
          else if (a.equalsIgnoreCase("N"))
          {
          	MAINMENU();
          }
 }     
public static void WITHDRAW2l()
{
          
          {
          Scanner SC = new Scanner(System.in);
          double SAVINGS = 30000;
          double CC = 40000;
          double ACC = SAVINGS + CC;
          System.out.println("\n_______________________________________________________");
          System.out.println("ACCOUNT");
          System.out.println("HOW MUCH WOULD YOU LIKE TO WITHDRAW?");
          double x = SC.nextDouble();
          cls();
          
          if(x <= ACC)
          {
          	System.out.println("PLEASE COUNT THE AMOUNT\n \tBEFORE YOU LEAVE");
          	System.out.println("\n_______________________________________________________");
          }
          else if (x > ACC )
          {
          	System.out.println("YOUR BALANCE IS NOT ENOUGH\nPLEASE CHECK YOUR BALANCE");
          	cls();
          	System.out.println("\n_______________________________________________________");
          }
          }
          {
         Scanner SC = new Scanner(System.in); 
          System.out.println("WOULD YOU LIKE TO TRANSACT AGAIN?Y/N");
          String y = SC.nextLine();
          cls();
          
          if ( y.equalsIgnoreCase("Y"))
           {
           MAINMENU();
           }
          else if ( y.equalsIgnoreCase("N"));
           {
           System.out.println("THANKYOU !");
           }
          }        

}
public static void WITHDRAW3()
{
          Scanner SC = new Scanner(System.in);
          System.out.println("\n_______________________________________________________");
          System.out.println("SAVINGS ACCOUNT");
          System.out.println("DO YOU WISH TO CONTINUE?Y/N");
          String a = SC.nextLine();
          cls();
          if (a.equalsIgnoreCase("Y"))
          {
          	WITHDRAW3l();
          }
          else if (a.equalsIgnoreCase("N"))
          {
          	MAINMENU();
          }    
}
public static void WITHDRAW3l()
{
          {
          Scanner SC = new Scanner(System.in);
          double SAVINGS = 30000;
          double CC = 40000;
          double ACC = SAVINGS + CC;
          System.out.println("\n_______________________________________________________");
          System.out.println("CREDIT CARD ACCOUNT");
          System.out.println("HOW MUCH WOULD YOU LIKE TO WITHDRAW?");
          double x = SC.nextDouble();
          
          cls();
          
          if(x <=CC )
          {
          	System.out.println("PLEASE COUNT THE AMOUNT\n \tBEFORE YOU LEAVE");
          	System.out.println("\n_______________________________________________________");
          }
          else if (x > CC )
          {
          	System.out.println("YOUR BALANCE IS NOT ENOUGH\nPLEASE CHECK YOUR BALANCE");
          	System.out.println("\n_______________________________________________________");
          	
          }
          }
          {
         Scanner SC = new Scanner(System.in); 
          System.out.println("WOULD YOU LIKE TO TRANSACT AGAIN?Y/N");
          String y = SC.nextLine();
          cls();
          
          if ( y.equalsIgnoreCase("Y"))
           {
           MAINMENU();
           }
          else if ( y.equalsIgnoreCase("N"));
           {
           System.out.println("THANKYOU!!!");
           }
          }        
}


public static void BALANCE()
{
          Scanner SC = new Scanner(System.in);
          
          System.out.println("\n_______________________________________________________");
          System.out.println("1 - SAVINGS ACCOUNT");
          System.out.println("2 - CHECKING ACCOUNT");
          System.out.println("3 - CREDIT CARD ACCOUNT");
          int x = SC.nextInt();
          cls();
          
          if ( x == 1 )
           {
           BALANCE1();
           } 
          else if ( x == 2 )
           {
           BALANCE2();
           }
          else if ( x == 3 )
           {
           BALANCE3();
           }
      }
public static void BALANCE1()
{
          Scanner SC = new Scanner(System.in);
          System.out.println("\n_______________________________________________________");
          System.out.println("SAVINGS ACCOUNT");
          System.out.println("DO YOU WISH TO CONTINUE?Y/N");
          String a = SC.nextLine();
          cls();
          if (a.equalsIgnoreCase("Y"))
          {
          	BALANCE1l();
          }
          else if (a.equalsIgnoreCase("N"))
          {
          	MAINMENU();
          }
}    
public static void BALANCE1l()
{
          Scanner SC = new Scanner(System.in);
          double SAVINGS = 30000;
          double CC = 40000;
          double ACC = SAVINGS + CC;
         System.out.println("YOUR SAVINGS ACCOUNT BALANCE");
          System.out.println(+ SAVINGS );
          System.out.println("WOULD YOU LIKE TO TRANSACT AGAIN?Y/N");
          String y = SC.nextLine();
          cls();
          
          if ( y.equalsIgnoreCase("Y"))
           {
           MAINMENU();
           }
          else if ( y.equalsIgnoreCase("N"));
           {
           System.out.println("THANKYOU!!!");
           }
      }
public static void BALANCE2()
{
          Scanner SC = new Scanner(System.in);
          System.out.println("\n_______________________________________________________");
          System.out.println("ACCOUNT");
          System.out.println("DO YOU WISH TO CONTINUE?Y/N");
          String a = SC.nextLine();
          cls();
          if (a.equalsIgnoreCase("Y"))
          {
          	BALANCE2l();
          }
          else if (a.equalsIgnoreCase("N"))
          {
          	MAINMENU();
          }
}      
public static void BALANCE2l()
{
          Scanner SC = new Scanner(System.in);
          double SAVINGS = 30000;
          double CC = 40000;
          double ACC = SAVINGS + CC;
          System.out.println("YOUR ACCOUNT BALANCE");
          System.out.println(+ ACC );
          System.out.println("WOULD YOU LIKE TO TRANSACT AGAIN?Y/N");
          String y = SC.nextLine();
          cls();
          
          
          if ( y.equalsIgnoreCase("Y"))
           {
           MAINMENU();
           }
          else if ( y.equalsIgnoreCase("N"));
           {
           System.out.println("THANKYOU!!!");
           }
      }
public static void BALANCE3()
{
          Scanner SC = new Scanner(System.in);
          System.out.println("\n_______________________________________________________");
          System.out.println("CREDIT CARD ACCOUNT");
          System.out.println("DO YOU WISH TO CONTINUE?Y/N");
          String a = SC.nextLine();
          cls();
          if (a.equalsIgnoreCase("Y"))
          {
          	BALANCE3l();
          }
          else if (a.equalsIgnoreCase("N"))
          {
          	MAINMENU();
          }
}       
public static void BALANCE3l()
{
          Scanner SC = new Scanner(System.in);
          double SAVINGS = 30000;
          double CC = 40000;
          double ACC = SAVINGS + CC;
          System.out.println("YOUR CREDIT CARD BALANCE");
          System.out.println(+ CC );
          System.out.println("WOULD YOU LIKE TO TRANSACT AGAIN?Y/N");
          String y = SC.nextLine();
          cls();
          
          if ( y.equalsIgnoreCase("Y"))
           {
           MAINMENU();
           }
          else if ( y.equalsIgnoreCase("N"));
           {
           System.out.println("THANKYOU!!!");
           }
      }
    public static void cls()
	{
		    System.out.print("\033[H\033[2J");
		    	    System.out.flush();
		    	    	}
}
