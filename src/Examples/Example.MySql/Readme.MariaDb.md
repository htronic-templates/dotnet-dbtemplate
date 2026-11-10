# Readme

Example of accessing a MariaDB Database

## Docker Compose Image

Example docker compose file `compose.yml`
```
services:
  db:
    image: mariadb:lts
    container_name: mariadb1
    restart: unless-stopped
    environment:
      MARIADB_DATABASE: dbtest
      MARIADB_USER: dbadmin
      MARIADB_PASSWORD: "%DemoPassword1234"
      MARIADB_ROOT_PASSWORD: "%DemoPassword1234"
    ports:
      - "3306:3306"
    volumes:
      - mariadb_data:/var/lib/mysql

volumes:
  mariadb_data:
```

## Bringing the docker container up

To bring the container up / down
```sh
# To bring the docker contaner up and run it in daemon mode
docker compose up -d
# To bring the docker container down / delete any stored volumes
docker compose down -v
```

## Create Test Table

A default database of dbtest should be created by the above.

```sql
CREATE TABLE test_table1 (
    idx INT NOT NULL AUTO_INCREMENT,
    test_integer INT NOT NULL,
    test_string VARCHAR(1024) NOT NULL,
    test_datetime DATETIME NOT NULL,
    PRIMARY KEY (idx)
);
```

Insert some values
```sql
INSERT INTO test_table1 (test_integer, test_string, test_datetime) VALUES (2, 'Hello World', '2026-09-13T15:30:00');
INSERT INTO test_table1 (test_integer, test_string, test_datetime) VALUES (3, 'Hello World2', '2026-10-13T15:30:00');
```
