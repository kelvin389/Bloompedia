using System;


namespace Bloompedia.utils
{
    public static class Utilites
    {
        public static string GetImagePath(int id, string extension)
        {
            return "images/uploaded/" + id + "." + extension;
        }
    }
}
