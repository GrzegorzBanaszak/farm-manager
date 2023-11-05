-- CreateEnum
CREATE TYPE "Position" AS ENUM ('Owner', 'Manager', 'Warehouseman', 'Employee');

-- CreateTable
CREATE TABLE "User" (
    "id" TEXT NOT NULL,
    "FullName" TEXT NOT NULL,
    "Position" "Position" NOT NULL DEFAULT 'Employee',
    "PhoneNumber" TEXT NOT NULL,

    CONSTRAINT "User_pkey" PRIMARY KEY ("id")
);
