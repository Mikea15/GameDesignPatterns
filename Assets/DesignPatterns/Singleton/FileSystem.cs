using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// .
/// http://gameprogrammingpatterns.com/singleton.html
/// </summary>

public class FileSystem
{
    public static FileSystem Instance()
    {
#if PLATFORM == PLAYSTATION3
        FileSystem instance = new PS3FileSystem();
#elif PLATFORM == WII
        FileSystem instance = new WiiFileSystem();
#endif
        return instance;
    }
    
	
    protected FileSystem( )
    {

    }

    public virtual string ReadFile(string path)
    {
        return "";
    }
    public virtual void WriteFile(string path, string contents)
    {

    }
}


public class PS3FileSystem : FileSystem
{

    public override string ReadFile(string path)
    {
        throw new NotImplementedException();
    }

    public override void WriteFile(string path, string contents)
    {
        throw new NotImplementedException();
    }
}

public class WiiFileSystem : FileSystem
{

    public override string ReadFile(string path)
    {
        throw new NotImplementedException();
    }

    public override void WriteFile(string path, string contents)
    {
        throw new NotImplementedException();
    }
}

