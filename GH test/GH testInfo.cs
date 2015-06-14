using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace GH_test
{
  public class GH testInfo : GH_AssemblyInfo
  {
    public override string Name
    {
      get
      {
        return "GHtest";
      }
    }
    public override Bitmap Icon
    {
      get
      {
        //Return a 24x24 pixel bitmap to represent this GHA library.
        return null;
      }
    }
    public override string Description
    {
      get
      {
        //Return a short string describing the purpose of this GHA library.
        return "";
      }
    }
    public override Guid Id
    {
      get
      {
        return new Guid("9b0fe810-ca3d-4ed1-b38f-b9a9af8e8393");
      }
    }

    public override string AuthorName
    {
      get
      {
        //Return a string identifying you or your company.
        return "";
      }
    }
    public override string AuthorContact
    {
      get
      {
        //Return a string representing your preferred contact details.
        return "";
      }
    }
  }
}
