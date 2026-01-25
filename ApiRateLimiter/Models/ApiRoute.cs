namespace Models{

    class ApiRoute{
        public string Name { get; private set; }
        public int Limit { get; private set; }
        public int CurrentCount { get; private set; }

        // Constructor: route must have a name and limit when created
        public ApiRoute(string name, int limit){
            Name = name;
            Limit = limit;
            CurrentCount = 0;
        }

        // Try to accept a request
        public bool AllowRequest(){
            if (CurrentCount >= Limit)
                return false;

            CurrentCount++;
            return true;
        }

        // Reset count 
        public void Reset(){
            CurrentCount = 0;
        }
    }
}
