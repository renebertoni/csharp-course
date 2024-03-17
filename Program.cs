Album album = new("Ten");

Song music1 = new ("Go", "Pearl Jam", 328, true);
Song music2 = new ("Alive", "Pearl Jam", 256, true);

album.AddSong(music1);
album.AddSong(music2);

album.ShowAllSongs();