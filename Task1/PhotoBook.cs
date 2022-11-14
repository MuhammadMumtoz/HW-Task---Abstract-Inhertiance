public class PhotoBook{
    protected int _numPages;
    public PhotoBook(){
        _numPages=16;
    }
    public PhotoBook(int numPages){
        _numPages = numPages;
    }
    public int GetNumPages(){
        return _numPages;
    }
}