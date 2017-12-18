Super Mario Brothers 2 Japan FDS Text Editor
Programmed by: Shawn M. Crawford [sleepy]
Last Update: July 20th, 2017 in C#
Latest Build: 1.0.2
 ----

Features:
	* edit every line of text in the game
	* this version tested with J rom (Super Mario Brothers 2 (Japan).fds), might work with other versions but untested because it relies on offsets in the ROM. An unheadered ROM is required.
	* The header of the FDS can't be altered with this version as it corrupts the ROM. Future versions might support this so for now the Text is displayed is all.
	* Make sure the ROM is not in use when editing.
Requires:
	* .Net Framework 3.5

Usage:
	*Open the Rom (Super Mario Brothers 2 (Japan).fds), change text, click "Update Text", make sure you have a backup in case something breaks.
	*Feel free to email bugs to sleepy3d@gmail.com

 ----
1.0.2 July 20th, 2017
-fixed bug that corrupted the FDS ROM image, 1 byte makes a difference...
 ----
1.0.1  July 3rd, 2017
-fixed major bug with writing text to the ROM
 ----
1.0  June 27th, 2017
-initial release
 ----