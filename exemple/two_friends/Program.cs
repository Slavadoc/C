// See https://aka.ms/new-console-template for more information

class ToFriends {
   public static void Main(){
      int distance = 10000;
      int firstFriendSpeed = 2;
      int secondFriendSpeed = 1;
      int dogSpeed = 5;
      int count = 0;
      int friend = 2;

      while(distance > 10){
         int time = 0;
         if( friend == 1) {
            time = distance / ( secondFriendSpeed + dogSpeed);
            friend = 2;
         } else {
            time = distance / ( firstFriendSpeed + dogSpeed);
            friend = 1;
         }
         distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time );
         //Console.WriteLine(distance);
         count++;
      }

      Console.WriteLine(count);

   }
}
