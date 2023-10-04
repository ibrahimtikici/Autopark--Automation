UPDATE seribilgileri
SET seri=NULL, marka=NULL;

ALTER TABLE seribilgileri
DROP COLUMN seri,marka;