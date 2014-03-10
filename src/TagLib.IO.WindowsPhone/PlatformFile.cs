using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLib.IO
{
	public class PlatformFile : TagLib.File.IFileAbstraction
	{
		/// <summary>
		///    Contains the name used to open the file.
		/// </summary>
		private string name;

		/// <summary>
		///    Constructs and initializes a new instance of
		///    <see cref="PlatformFile" /> for a
		///    specified path in the local file system.
		/// </summary>
		/// <param name="path">
		///    A <see cref="string" /> object containing the
		///    path of the file to use in the new instance.
		/// </param>
		/// <exception cref="ArgumentNullException">
		///    <paramref name="path" /> is <see langword="null"
		///    />.
		/// </exception>
		public PlatformFile(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			name = path;
		}

		/// <summary>
		///    Gets the path of the file represented by the
		///    current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the
		///    path of the file represented by the current
		///    instance.
		/// </value>
		public string Name
		{
			get { return name; }
		}

		/// <summary>
		///    Gets a new readable, seekable stream from the
		///    file represented by the current instance.
		/// </summary>
		/// <value>
		///    A new <see cref="System.IO.Stream" /> to be used
		///    when reading the file represented by the current
		///    instance.
		/// </value>
		public System.IO.Stream ReadStream
		{
			get
			{
				return System.IO.File.Open(Name,
					System.IO.FileMode.Open,
					System.IO.FileAccess.Read,
					System.IO.FileShare.Read);
			}
		}

		/// <summary>
		///    Gets a new writable, seekable stream from the
		///    file represented by the current instance.
		/// </summary>
		/// <value>
		///    A new <see cref="System.IO.Stream" /> to be used
		///    when writing to the file represented by the
		///    current instance.
		/// </value>
		public System.IO.Stream WriteStream
		{
			get
			{
				return System.IO.File.Open(Name,
					System.IO.FileMode.Open,
					System.IO.FileAccess.ReadWrite);
			}
		}

		/// <summary>
		///    Closes a stream created by the current instance.
		/// </summary>
		/// <param name="stream">
		///    A <see cref="System.IO.Stream" /> object
		///    created by the current instance.
		/// </param>
		public void CloseStream(System.IO.Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");

			stream.Dispose();
		}
	}
}
