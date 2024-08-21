Zapper Assessment
You should spend no longer than an hour on the assessment.

The results should be committed to github and a link provided as the result.
Question 1 - Database Design
At Zapper we facilitate transactions between our customers and merchants.

Write SQL to define data structures which could help us track transactions.
Question 2 - User Settings
A user profile has 8 boolean settings which determines their functionality.


1 - SMS Notifications Enabled

2 - Push Notifications Enabled

3 - Bio-metrics Enabled

4 - Camera Enabled

5 - Location Enabled

6 - NFC Enabled

7 - Vouchers Enabled

8 - Loyalty Enabled
Question 2.1 Checking if a feature is enabled
If a users settings were represented as a string where each position represents a
different setting. Write a function which can determine if user has a specific feature
enabled.
Test cases:

Input: settings = 00000000, setting = 7

Output: false


Input: settings = 00000010, setting = 7

Output: true
Input: settings = 11111111, setting = 4

Output: true
Question 2.2 Storing user settings
Write some functions which can read and write the settings to a file in the least
amount of space.
