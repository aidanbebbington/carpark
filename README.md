# Assumptions

* All dates & times in the local timezone (of the carpark)
* Early Bird only applies if entry and exit occur on the same day
* "midnight on Friday" actually refers to 00:00 on Saturday morning
* If multiple rates are applicable the cheapest should be used

# Potential Improvements

* If timezone support is required something like Nodatime is very useful
* Could extract extensions such as DateTimeExtensions to a shared Nuget, or potentially find another library if it more complex operations are required
* Extract rate constants to configuration or external data source to enable updating
