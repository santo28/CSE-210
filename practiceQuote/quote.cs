public class Quote {
    private string author = "";
    private string quote = "";
    private Source source;
//this is a consturctor because it has the same name as the class " QUOTE "
    public Quote (string person, string quote, Source source){
            this.author = person;
            this.quote = quote;
            this.source = source;
    }

    public bool HasAuthor(string name) {
        if(author.ToUpper().Contains(name.ToUpper())){
            return true;
        }
        return false;
}
public string GetQuote(){
    string url = source.getUrl();
    url = url != "" ? $"[{url}]" : "";
    //if (url!= ""){
      //      url = $"[{url}]"
    //}

return $"\"{quote}\"\n{author} - {source.getName()}{url}";

}
}