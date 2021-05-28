using System;
using System.IO;
using System.Net;
using System.Text;

namespace CandidateTesting.DanielVPonceDeLeon.iTaaS.Helpers
{
    public class IO
    {
        public Stream StreamFile(string file)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    Stream stream = client.OpenRead(file);
                    return stream;
                }
            }
            catch (WebException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }

        public string ReadFile(Stream file)
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    byte[] buffer = new byte[2048];
                    int bytesRead;
                    while ((bytesRead = file.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        stream.Write(buffer, 0, bytesRead);
                    }
                    byte[] result = stream.ToArray();
                    return Encoding.UTF8.GetString(result, 0, result.Length - 1);
                }
            }
            catch (DecoderFallbackException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (NotSupportedException)
            {
                throw;
            }
            catch (ObjectDisposedException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public void SaveFile(string file, string outPath)
        {
            try
            {
                var folderPath = Path.GetDirectoryName(outPath).ToString();
                Directory.CreateDirectory(folderPath);
                var filename = Path.GetFileName(outPath);
                var fullPath = Path.Combine(folderPath, filename);
                byte[] fileBytes = new UTF8Encoding(true).GetBytes(file);
                int bufferSize = 2048;

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize))
                {
                    fs.Write(fileBytes, 0, fileBytes.Length);
                }
            }
            catch (UnauthorizedAccessException)
            {
                throw;
            }
            catch (PathTooLongException)
            {
                throw;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (NotSupportedException)
            {
                throw;
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}