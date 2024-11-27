using System;
using Telerik.Web.UI;

public partial class ImageUploader1 : System.Web.UI.Page
{
    public const int UserID = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Populate the default (base) upload configuration into an object of type SampleAsyncUploadConfiguration
        SampleAsyncUploadConfiguration config =
            RadAsyncUpload1.CreateDefaultUploadConfiguration<SampleAsyncUploadConfiguration>();

        // Populate any additional fields
        config.UserID = 1;

        // The upload configuration will be available in the handler
        RadAsyncUpload1.UploadConfiguration = config;

        RadAsyncUpload1.FileUploaded += new FileUploadedEventHandler(RadAsyncUpload1_FileUploaded);
    }

    protected void RadAsyncUpload1_FileUploaded(object sender, FileUploadedEventArgs e)
    {
        SampleAsyncUploadResult result = e.UploadResult as SampleAsyncUploadResult;
    }
}
