using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLib.IO
{
	public class File
	{
		/// <summary>
		///    Creates a new instance of a <see cref="File" /> subclass
		///    for a specified path, guessing the mime-type from the
		///    file's extension and using the average read style.
		/// </summary>
		/// <param name="path">
		///    A <see cref="string" /> object specifying the file to
		///    read from and write to.
		/// </param>
		/// <returns>
		///    A new instance of <see cref="File" /> as read from the
		///    specified path.
		/// </returns>
		/// <exception cref="CorruptFileException">
		///    The file could not be read due to corruption.
		/// </exception>
		/// <exception cref="UnsupportedFormatException">
		///    The file could not be read because the mime-type could
		///    not be resolved or the library does not support an
		///    internal feature of the file crucial to its reading.
		/// </exception>
		public static TagLib.File Create(string path)
		{
			return Create(path, null, ReadStyle.Average);
		}

		/// <summary>
		///    Creates a new instance of a <see cref="File" /> subclass
		///    for a specified path and read style, guessing the
		///    mime-type from the file's extension.
		/// </summary>
		/// <param name="path">
		///    A <see cref="string" /> object specifying the file to
		///    read from and write to.
		/// </param>
		/// <param name="propertiesStyle">
		///    A <see cref="ReadStyle" /> value specifying the level of
		///    detail to use when reading the media information from the
		///    new instance.
		/// </param>
		/// <returns>
		///    A new instance of <see cref="File" /> as read from the
		///    specified path.
		/// </returns>
		/// <exception cref="CorruptFileException">
		///    The file could not be read due to corruption.
		/// </exception>
		/// <exception cref="UnsupportedFormatException">
		///    The file could not be read because the mime-type could
		///    not be resolved or the library does not support an
		///    internal feature of the file crucial to its reading.
		/// </exception>
		public static TagLib.File Create(string path, ReadStyle propertiesStyle)
		{
			return Create(path, null, propertiesStyle);
		}

		/// <summary>
		///    Creates a new instance of a <see cref="File" /> subclass
		///    for a specified path, mime-type, and read style.
		/// </summary>
		/// <param name="path">
		///    A <see cref="string" /> object specifying the file to
		///    read from and write to.
		/// </param>
		/// <param name="mimetype">
		///    A <see cref="string" /> object containing the mime-type
		///    to use when selecting the appropriate class to use, or
		///    <see langword="null" /> if the extension in <paramref
		///    name="abstraction" /> is to be used.
		/// </param>
		/// <param name="propertiesStyle">
		///    A <see cref="ReadStyle" /> value specifying the level of
		///    detail to use when reading the media information from the
		///    new instance.
		/// </param>
		/// <returns>
		///    A new instance of <see cref="File" /> as read from the
		///    specified path.
		/// </returns>
		/// <exception cref="CorruptFileException">
		///    The file could not be read due to corruption.
		/// </exception>
		/// <exception cref="UnsupportedFormatException">
		///    The file could not be read because the mime-type could
		///    not be resolved or the library does not support an
		///    internal feature of the file crucial to its reading.
		/// </exception>
		public static TagLib.File Create(string path, string mimetype, ReadStyle propertiesStyle)
		{
			return TagLib.File.Create(new PlatformFile(path), mimetype, propertiesStyle);
		}
	}
}
