﻿namespace QRCoder
{
    /// <summary>
    /// Abstract base class for generating QR codes. 
    /// Derived classes typically render a QR code into a specific format (png, System.Drawing.Bitmap, PDF, etc).
    /// </summary>
    public abstract class AbstractQRCode
    {
        /// <summary>
        /// Gets or sets the QRCodeData used to generate the QR code.
        /// </summary>
        protected QRCodeData QrCodeData { get; set; }

        /// <summary>
        /// Initializes a new instance of the AbstractQRCode class.
        /// </summary>
        protected AbstractQRCode() {
        }

        /// <summary>
        /// Initializes a new instance of the AbstractQRCode class with the specified QRCodeData.
        /// </summary>
        /// <param name="data">The QRCodeData object generated by QRCodeGenerator.CreateQrCode().</param>
        protected AbstractQRCode(QRCodeData data) {
            this.QrCodeData = data;
        }

        /// <summary>
        /// Sets the QRCodeData object that will be used to generate the QR code. 
        /// This method is useful for COM objects connections.
        /// </summary>
        /// <param name="data">The QRCodeData object generated by QRCodeGenerator.CreateQrCode().</param>
        virtual public void SetQRCodeData(QRCodeData data) {
            this.QrCodeData = data;
        }

        /// <summary>
        /// Disposes the QRCodeData object.
        /// </summary>
        public void Dispose()
        {
            this.QrCodeData?.Dispose();
            this.QrCodeData = null;
        }
    }
}
