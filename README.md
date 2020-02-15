# Assumptions

* All dates & times are in local time (of the carpark)
* Early Bird only applies if entry and exit occur on the same day
* "midnight on Friday" actually refers to 00:00 on Saturday morning
* If multiple rates are applicable the cheapest should apply

# Potential Improvements

* Extract pricing rate constants to configuration or external data source to allow them to be updated and vary by environment or parking provider
* If timezone support is required something like Nodatime is very useful
* Could extract extensions such as DateTimeExtensions to a shared Nuget, or potentially find another library if it more complex operations are required
