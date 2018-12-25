using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Summary description for FileCommon
/// </summary>
public class FileCommon
{
	public FileCommon()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string UploadFile(String pathFolderIncludeFile, HttpPostedFile newAttach)
    {
        string result="";
        String newfilename = "";
        string filename = "";

        try
        {
            string filename1 = "";
            filename = newAttach.FileName;
            if (filename != "")
            {
                filename1 = filename.Substring(filename.LastIndexOf("\\") + 1);
                newfilename = Regex.Replace(filename1, @"[;~!@#$%^&*?;()_+=`' ]", "-");
                if (System.IO.File.Exists(HttpContext.Current.Server.MapPath("~" + pathFolderIncludeFile + newfilename)))
                {
                    newfilename = newfilename.Replace(".", DateTime.Now.ToString("ddMMyyyyhhmmss") + ".");
                }
                
                newAttach.SaveAs(HttpContext.Current.Server.MapPath("~" + pathFolderIncludeFile + newfilename));
                result = pathFolderIncludeFile + newfilename;
            }
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert(\"File " + filename + "đã tồn tại .\");</script>");
            throw ex;
        }

        return result;
    }
}