namespace EZ.Retrier;

public static class Retry
{
    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static async Task<TOutput> ExecuteAsync<TOutput>(
        Func<Task<TOutput>> method,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return await method();
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return await ExecuteAsync(method, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameters for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static async Task<TOutput> ExecuteAsync<TInput, TOutput>(
        Func<TInput, Task<TOutput>> method,
        TInput param,
        int numberOfRetries = 3, int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0) throw new RetryException($"Retry failed all the times for method {method}.");

            return await method(param);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return await ExecuteAsync(method, param, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameter for the method which will be run</param>
    /// <param name="param1">Parameter for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static async Task<TOutput> ExecuteAsync<TInput, TInput1, TOutput>(
        Func<TInput, TInput1, Task<TOutput>> method,
        TInput param,
        TInput1 param1,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return await method(param, param1);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return await ExecuteAsync(method, param, param1, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameters for the method which will be run</param>
    /// <param name="param1">Parameters for the method which will be run</param>
    /// <param name="param2">Parameters for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static async Task<TOutput> ExecuteAsync<TInput, TInput1, TInput2, TOutput>(
        Func<TInput, TInput1, TInput2, Task<TOutput>> method,
        TInput param,
        TInput1 param1,
        TInput2 param2,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return await method(param, param1, param2);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return await ExecuteAsync(method, param, param1, param2, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameters for the method which will be run</param>
    /// <param name="param1">Parameters for the method which will be run</param>
    /// <param name="param2">Parameters for the method which will be run</param>
    /// <param name="param3">Parameters for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static async Task<TOutput> ExecuteAsync<TInput, TInput1, TInput2, TInput3, TOutput>(
        Func<TInput, TInput1, TInput2, TInput3, Task<TOutput>> method,
        TInput param,
        TInput1 param1,
        TInput2 param2,
        TInput3 param3,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return await method(param, param1, param2, param3);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return await ExecuteAsync(method, param, param1, param2, param3, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static TOutput Execute<TOutput>(
        Func<TOutput> method,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return method();
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return Execute(method, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameters for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static TOutput Execute<TInput, TOutput>(
        Func<TInput, TOutput> method,
        TInput param,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return method(param);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return Execute(method, param, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameter for the method which will be run</param>
    /// <param name="param1">Parameter for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static TOutput Execute<TInput, TInput1, TOutput>(
        Func<TInput, TInput1, TOutput> method,
        TInput param,
        TInput1 param1,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return method(param, param1);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return Execute(method, param, param1, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameters for the method which will be run</param>
    /// <param name="param1">Parameters for the method which will be run</param>
    /// <param name="param2">Parameters for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static TOutput Execute<TInput, TInput1, TInput2, TOutput>(
        Func<TInput, TInput1, TInput2, TOutput> method,
        TInput param,
        TInput1 param1,
        TInput2 param2,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return method(param, param1, param2);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return Execute(method, param, param1, param2, numberOfRetries - 1, timeoutInSeconds);
        }
    }

    /// <summary>
    /// Retries anything for a given amount of tries, and waits for the other retry for a given amount of timeout
    /// </summary>
    /// <param name="numberOfRetries">Number of times do you want to run the method</param>
    /// <param name="method">Method which will be run</param>
    /// <param name="param">Parameters for the method which will be run</param>
    /// <param name="param1">Parameters for the method which will be run</param>
    /// <param name="param2">Parameters for the method which will be run</param>
    /// <param name="param3">Parameters for the method which will be run</param>
    /// <param name="timeoutInSeconds">Default timeout is 1 minute/60 seconds</param>
    /// <returns></returns>
    /// <exception cref="RetryException"></exception>
    public static TOutput Execute<TInput, TInput1, TInput2, TInput3, TOutput>(
        Func<TInput, TInput1, TInput2, TInput3, TOutput> method,
        TInput param,
        TInput1 param1,
        TInput2 param2,
        TInput3 param3,
        int numberOfRetries = 3,
        int timeoutInSeconds = 5)
    {
        try
        {
            if (numberOfRetries == 0)
                throw new RetryException($"Retry failed all the times for method {method.Method.Name}.");

            return method(param, param1, param2, param3);
        }
        catch (RetryException)
        {
            throw;
        }
        catch (Exception)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSeconds));

            return Execute(method, param, param1, param2, param3, numberOfRetries - 1, timeoutInSeconds);
        }
    }
}