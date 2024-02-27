

List<string> sehiler0 = new List<string>();
sehiler0.Add("Ankara"); 
Console.WriteLine(sehiler0.Count);
Mylist<string> sehirler = new Mylist<string>();
sehirler.Add("Ankara");
sehirler.Add("istanbul");
Console.WriteLine(sehirler.Count);


class Mylist<T> {


    T[] _arrays;
    T[] _tempArrays;
    public Mylist()
    {
        _arrays = new T[0]; 
    }
    public void Add (T item ) {

        _tempArrays = _arrays;

        _tempArrays = _arrays;
        
        _arrays  = new T[_arrays.Length+1];
        for ( int i = 0; i < _tempArrays.Length; i++)
        {
            _arrays[i]= _tempArrays[i];

        }
        _arrays[_arrays.Length-1] = item;
    }


  
    public int Count
    {
        get { return _arrays.Length; }
    
    }

}