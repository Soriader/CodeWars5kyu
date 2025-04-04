namespace CodeWars5kyu;

public class DomainNameValidatorTask
{
    public static bool Validate(string domain) 
    {
        if (string.IsNullOrEmpty(domain))
        {
            return false;
        }        
        if (domain.Length > 253)
        {
            return false;
        }        
        if (domain.Contains("@") || domain.Contains("..") || domain.Contains(" "))
        {
            return false;
        }        
        if (domain.StartsWith(".") || domain.EndsWith(".") || domain.StartsWith("-") || domain.EndsWith("-"))
        {
            return false;
        }

        var levels = domain.Split('.');
        
        if (levels.Length < 2)
        {
            return false;
        }        
        if (levels.Length > 127)
        {
            return false;
        }
        foreach (var level in levels)
        {
            if (level.Length == 0 || level.Length > 63)
            {
                return false;
            }            
            if (level.StartsWith("-") || level.EndsWith("-"))
            {
                return false;
            }            
            if (!level.All(c => char.IsLetterOrDigit(c) || c == '-'))
            {
                return false;
            }
            
            if (!level.All(c => 
                    (c >= 'a' && c <= 'z') || 
                    (c >= 'A' && c <= 'Z') || 
                    (c >= '0' && c <= '9') || 
                    c == '-'))
            {
                return false;
            }
        }

        var tld = levels.Last();
        
        if (tld.All(char.IsDigit))
        {
            return false;
        }
        return true;
    }
}