using System;

public class Program
{
	public static void Main(string[] args)
	{
		//abstract class
		Console.WriteLine("ABSTRACT CLASS");
		perpustakaan perpustakaan;

		perpustakaan = new penjagaperpustakaan();
		perpustakaan.pinjam();
		perpustakaan.kembalikan();

		Console.WriteLine();
		perpustakaan = new peminjam();
		perpustakaan.pinjam();
		perpustakaan.kembalikan();

		Console.WriteLine();
		Console.WriteLine();

		//interface
		Console.WriteLine("INTERFACE");
		Ifotocopy fotocopy;

		fotocopy = new scanner();
		fotocopy.info();
		fotocopy.fungsi();

		Console.WriteLine();
		fotocopy = new printer();
		fotocopy.info();
		fotocopy.fungsi();

		Console.WriteLine();
		fotocopy = new jilid();
		fotocopy.info();
		fotocopy.fungsi();
	}
}

//abstract class
public abstract class perpustakaan
{
	public abstract void pinjam();
	public abstract void kembalikan();
}

public class penjagaperpustakaan : perpustakaan
{
	public override void pinjam()
	{
		Console.WriteLine("penjagaperpustakaan memberikan buku kepada peminjam");
	}

	public override void kembalikan()
	{
		Console.WriteLine("penjagaperpustakaan menerima buka dari peminjam");
	}
}

public class peminjam : perpustakaan
{
	public override void pinjam()
	{
		Console.WriteLine("Peminjam meminjam buku");
	}

	public override void kembalikan()
	{
		Console.WriteLine("Peminjam mengembalikan buku");
	}
}

//interface
public interface Ifotocopy
{
	void info();
	void fungsi();
}

public class scanner : Ifotocopy
{
	public void info()
	{
		Console.WriteLine("fungsi scanner : ");
	}

	public void fungsi()
	{
		Console.WriteLine("mengscan foto atau ganmbar");
	}
}

public class printer : Ifotocopy
{
	public void info()
	{
		Console.WriteLine("fungsi printer : ");
	}

	public void fungsi()
	{
		Console.WriteLine("memfotokopi foto, tulisan, dll");
	}
}

public class jilid: Ifotocopy
{
	public void info()
	{
		Console.WriteLine("fungsi jilid : ");
	}

	public void fungsi()
	{
		Console.WriteLine("untuk membuat terlihat rapi");
	}
}