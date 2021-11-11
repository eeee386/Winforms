CREATE TABLE Music (
  ID integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  Title text NOT NULL,
  Artist text NOT NULL,
  PublishYear integer NOT NULL,
  MusicLength integer NOT NULL,
  Priority integer NOT NULL,
  UNIQUE(Title)
);
