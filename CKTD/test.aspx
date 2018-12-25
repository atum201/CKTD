<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <script src="/ckeditor/ckeditor.js"></script>
    <script>
        CKEDITOR.replace('editor1');
    </script>
    <textarea name="editor1" id="editor1" rows="10" cols="80">
    This is my textarea to be replaced with CKEditor.
    </textarea>
    <div>
    
    </div>
    </form>
</body>
</html>
