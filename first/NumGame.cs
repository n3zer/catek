namespace first;

public class NumGame
{
  private int _maxNum;
  private Random _random;


  public NumGame(int maxNum = 100)
  {
    _maxNum = maxNum;
    _random = new Random();
  }
   
  internal void StartGame(){
    int randomNum = _random.Next(_maxNum);
    int userNum = 0;
  
    while (randomNum != userNum)
    {
      if(!GetUserNum(ref userNum)){
        Console.WriteLine("Incorect value, enter only int!");
        continue;    
      }
      Console.WriteLine(GetGameAnswer(userNum, randomNum));
    }
  }

  private string GetGameAnswer(int userNum, int randomNum){
    if(userNum < randomNum)
      return "Num is greater";
    else if(userNum > randomNum)
      return "Num is less";
    return "U win";
  }

  private bool GetUserNum(ref int o){
    string input = Console.ReadLine();
    bool isParsed = Int32.TryParse(input, out o);
    return isParsed;
  }
    
}

